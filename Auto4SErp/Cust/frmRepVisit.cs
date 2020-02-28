using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comm;
using Bll.Repair;
using Bll;
using Model;
namespace Auto4SErp.Cust
{
    public partial class frmRepVisit : ifrmBase
    {
        private IRepair mIRepair;
        private List<SqlElement> mLstE;
        private IVisit mIVisit;
        private string mDH;
        public frmRepVisit()
        {
            mIRepair = BllFactory.GetRepariBll();
            mIVisit = BllFactory.GetVisitBll();
            InitializeComponent();
            tsbFirst = bindingNavigatorMoveFirstItem;
            tsbLast = bindingNavigatorMoveLastItem;
            tsbPre = bindingNavigatorMovePreviousItem;
            tsbNext = bindingNavigatorMoveNextItem;
            tstbPageCount = bindingNavigatorCountItem;
            tstbPageCurrent = bindingNavigatorPositionItem;
            tstbRecordCount = bindingNavigatorRecordCount;
        }

        private void frmRepVisit_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            string strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            string strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());

            SetTButtonPng(toolStrip1);
            mLstControls.Add(txtCustName);
            mLstControls.Add(txtVin);
            mLstControls.Add(txtPlateNum);
            DoQuery();
        }

        protected override void DoQuery()
        {
            string strBegin = "";
            string strEnd = "";
            int tmpRecordCount;
            int tmpPageCount;
            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";
            DataTable dt = mIRepair.GetRepairsOfQuery1(mLstE, 2, strBegin, strEnd, null, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            dgRepair.AutoGenerateColumns = false;
            dgRepair.DataSource = dt;
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            if (dgRepair.SelectedRows.Count != 0)
            {
                frmDlgRepVisit frm = new frmDlgRepVisit();
                DataGridViewRow seldr = dgRepair.SelectedRows[0];
                string strdh = seldr.Cells["dh"].Value.ToString();

                frm.DH = strdh;
                frm.ShowDialogEx();

            }
        }

        private void RefreshVisitsOfDH(string dh)
        {
            DataTable dt = mIVisit.GetVisitsOfDH(dh);
            dgVisit.AutoGenerateColumns = false;
            dgVisit.DataSource = dt;
        }

        private void dgRepair_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgRepair_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRepair.SelectedRows.Count != 0)
            {
                frmDlgRepVisit frm = new frmDlgRepVisit();
                DataGridViewRow seldr = dgRepair.SelectedRows[0];
                string strdh = seldr.Cells["dh"].Value.ToString();
                mDH = strdh;
                RefreshVisitsOfDH(strdh);

            }
        }

        private void cbtnDel_Click(object sender, EventArgs e)
        {
            if (dgVisit.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgVisit.SelectedRows[0];
                string id = seldr.Cells["id"].Value.ToString();
                mIVisit.DelVisit(id);
                RefreshVisitsOfDH(mDH);
            }
        }

        private void cbtnModify_Click(object sender, EventArgs e)
        {
            if (dgVisit.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgVisit.SelectedRows[0];
                string id = seldr.Cells["id"].Value.ToString();
                frmDlgRepVisit frm = new frmDlgRepVisit();
                frm.DH = mDH;
                frm.ID = id;
                frm.ShowDialogEx();
                RefreshVisitsOfDH(mDH);

            }
        }
    }
}
