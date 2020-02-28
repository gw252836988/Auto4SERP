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
    public partial class frmAccEOQuery : ifrmBase
    {

        private List<SqlElement> mLstE;
        private IAccElseOut mIAccElseOut;
        public frmAccEOQuery()
        {
            mIAccElseOut = BllFactory.GetAccElseOutBll();
            InitializeComponent();
            tsbFirst = bindingNavigatorMoveFirstItem;
            tsbLast = bindingNavigatorMoveLastItem;
            tsbPre = bindingNavigatorMovePreviousItem;
            tsbNext = bindingNavigatorMoveNextItem;
            tstbPageCount = bindingNavigatorCountItem;
            tstbPageCurrent = bindingNavigatorPositionItem;
            tstbRecordCount = bindingNavigatorRecordCount;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            List<Pair> lst = AssginToListOfQuery();
            mLstE = CreateMedialSqlElement(lst);
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
            dt = mIAccElseOut.GetElseOutBills(strBegin, strEnd, mLstE, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            DataToControl(dt);
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();

        }

        private void DataToControl(DataTable dt)
        {


            dgRepair.DataSource = dt;



        }

        private void frmAccEOQuery_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            mLstControls.Add(cmbOutType);
            mLstControls.Add(txtCreator);
            SetTButtonPng(toolStrip1);
            LoadExtendContents("出库方式", cmbOutType);
            cmbOutType.SelectedIndex = -1;
            DoQuery();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dgRepair.SelectedRows.Count != 0)
            {

                frmAccElseOut frm = new frmAccElseOut();
                DataGridViewRow seldr = dgRepair.SelectedRows[0];
                string strdh = seldr.Cells[1].Value.ToString();
                frm.DH = strdh;

                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                        DoQuery();

                });
                frm.ShowDialogEx();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAccElseOut frm = new frmAccElseOut();
            frm.setRefreshDelegate(delegate(bool isR)
            {

                DoQuery();

            });
            frm.ShowDialogEx();
        }
    }
}
