﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Model;
using Bll.Sale;
namespace Auto4SErp.Sale
{
    public partial class frmCustInQuery : ifrmBase
    {
        private List<SqlElement> mLstE;
        private ICustVist mICustVist;
        private DataTable mDicOfCustomer;
        private DataTable mDicOfCustIn;
        public frmCustInQuery()
        {
            InitializeComponent();
            mICustVist = BllFactory.GetCustVistBll();
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



            dt = mICustVist.GetCustIns(strBegin, strEnd, mLstE, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();
            DataToControl(dt);


        }
        private void DataToControl(DataTable dt)
        {

            FrmAssist.UpdateColumns(ref mDicOfCustIn, dt, 11);
            FrmAssist.UpdateColumns(ref mDicOfCustomer, dt, 2);
            dgCustIn.DataSource = dt;
            dgCustIn.Columns["ID"].Visible = false;

        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {
            if (dgCustIn.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgCustIn.SelectedRows[0];
                string strbh = seldr.Cells[0].Value.ToString();

                frmDlgCustVist frm = new frmDlgCustVist();
                frm.ID = int.Parse(strbh);
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    DoQuery();

                });
                frm.ShowDialogEx();
            }
        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            frmDlgCustVist frm = new frmDlgCustVist();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                DoQuery();

            });
            frm.ShowDialogEx();
        }

        private void frmCustInQuery_Load(object sender, EventArgs e)
        {

            mLstControls.Add(txtCustName);
            mLstControls.Add(txtDH);
            mLstControls.Add(txtMobile);

            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            DoQuery();
            SetTButtonPng(toolStrip1);
        }

        private void dgCustIn_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //if (dataGridView1.Rows.Count - 1 == e.RowIndex)
            //{
            DrawGridID(e);

        }
    }
}
