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
using Bll.Sale;

namespace Auto4SErp.Sale
{
    public partial class frmCarAllotQuery : ifrmBase
    {
        private ICarSale mICarSale;

        private List<SqlElement> mLstE;
        public frmCarAllotQuery()
        {
            InitializeComponent();
            mICarSale = BllFactory.GetCarSaleBll();
            tsbFirst = bindingNavigatorMoveFirstItem;
            tsbLast = bindingNavigatorMoveLastItem;
            tsbPre = bindingNavigatorMovePreviousItem;
            tsbNext = bindingNavigatorMoveNextItem;
            tstbPageCount = bindingNavigatorCountItem;
            tstbPageCurrent = bindingNavigatorPositionItem;
            tstbRecordCount = bindingNavigatorRecordCount;
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
        }

        protected override void DoQuery()
        {
            DataTable dt;
            string strBegin = "";
            string strEnd = "";
            int tmpRecordCount;
            int tmpPageCount;
            if (chbIsDate.Checked)
            {
                strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            }


            dt = mICarSale.GetCarAllotsByQuery(strBegin, strEnd, mLstE, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();
            dgCarAllot.DataSource = dt;



        }

        private void frmCarAllotQuery_Load(object sender, EventArgs e)
        {

            mLstControls.Add(txtDH);
            mLstControls.Add(txtAllotUnit);
            mLstControls.Add(txtVin);
            SetTButtonPng(toolStrip1);
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            string strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            string strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
        }

        private void tbtbOpen_Click(object sender, EventArgs e)
        {

            if (dgCarAllot.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgCarAllot.SelectedRows[0];
                string strbh = seldr.Cells["DH"].Value.ToString();

                frmCarAllot frm = new frmCarAllot();
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                        DoQuery();

                });
                frm.DH = strbh;
                frm.ShowDialogEx();
            }
        }

        private void tbtbAdd_Click(object sender, EventArgs e)
        {
            frmCarAllot frm = new frmCarAllot();
            frm.setRefreshDelegate(b => { if (b)DoQuery(); });
            frm.ShowDialogEx();

        }
    }
}
