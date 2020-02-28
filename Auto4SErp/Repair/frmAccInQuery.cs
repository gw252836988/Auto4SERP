using System;
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
using Bll.Repair;

namespace Auto4SErp.Repair
{
    public partial class frmAccInQuery : ifrmBase
    {
        private List<SqlElement> mLstE;
        private IAccessory mIAccessory;
        private DataTable mDicOfAccIn;
        private IAccessoryIn mIAccessoryIn;
        private IExtend mIExtend;
        public frmAccInQuery()
        {
            mIAccessory = BllFactory.GetAccessoryBll();
            mIAccessoryIn = BllFactory.GetAccessoryInBll();
            mIExtend = BllFactory.GetExtendBll();
            InitializeComponent();

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


            dt = mIAccessoryIn.GetAccInHsOfQuery(strBegin, strEnd, mLstE, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            DataToControl(dt);
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();
            return;

        }

        private void DataToControl(DataTable dt)
        {

            FrmAssist.UpdateColumns(ref mDicOfAccIn, dt, 17);
            dgAccIn.DataSource = dt;

        }

        private void frmAccInQuery_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtDH);
            mLstControls.Add(cmbSupplyUnit);
            mLstControls.Add(txtOperatorMan);
            DataTable dt = mIExtend.GetSupplyUnits("售后");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbSupplyUnit.Items.Add(dt.Rows[i][1].ToString());
            }

            DateTime dtNow = DateTime.Now;

            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            SetTButtonPng(toolStrip1);
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {
            if (dgAccIn.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgAccIn.SelectedRows[0];
                string strdh = seldr.Cells[1].Value.ToString();

                frmAccIn frm = new frmAccIn();
                frm.DH = strdh;
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                        DoQuery();

                });
                frm.ShowDialogEx();

            }
        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            frmAccIn frm = new frmAccIn();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                DoQuery();

            });
            frm.ShowDialogEx();
        }

        private void btnCustomerFind_Click(object sender, EventArgs e)
        {
            frmSupplyUnit frm = new frmSupplyUnit();
            frm.ShowDialogEx();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
