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
using Bll.Sale;
namespace Auto4SErp.Sale
{
    public partial class frmCarInHQuery : ifrmBase
    {
        private ICarStock mICarStock;
        private DataTable mDicOfCarInH;
        private List<SqlElement> mLstE;
        private IExtend mIExtend;

        public frmCarInHQuery()
        {
            InitializeComponent();
            mICarStock = BllFactory.GetCarStockBll();
            mIExtend = BllFactory.GetExtendBll();
            tsbFirst = bindingNavigatorMoveFirstItem;
            tsbLast = bindingNavigatorMoveLastItem;
            tsbPre = bindingNavigatorMovePreviousItem;
            tsbNext = bindingNavigatorMoveNextItem;
            tstbPageCount = bindingNavigatorCountItem;
            tstbPageCurrent = bindingNavigatorPositionItem;
            tstbRecordCount = bindingNavigatorRecordCount;
        }

        private void frmDlgCarInHSel_Load(object sender, EventArgs e)
        {
            //StartWork();
            mLstControls.Add(txtDH);
            mLstControls.Add(cmbSupplier);
            DateTime dtNow = DateTime.Now;

            DataTable dt = mIExtend.GetSupplyUnits("销售");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbSupplier.Items.Add(dt.Rows[i][1].ToString());
            }

            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");

            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
            SetTButtonPng(toolStrip1);
        }


        protected override void DoworkInBack(object sender, DoWorkEventArgs e)
        {
            DataTable dt = mICarStock.GetCarInHsOfDefault();
            FrmAssist.UpdateColumns(ref mDicOfCarInH, dt, 3);
            e.Result = dt;

        }


        protected override void DoBackatCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DataTable dt = (DataTable)e.Result;
            dgCarInH.DataSource = dt;

        }

        private void dgCarInH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCarInH.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgCarInH.SelectedRows[0];
                string strbh = seldr.Cells[1].Value.ToString();

                if (m_del != null)
                {
                    m_del(strbh);
                }
                this.Close();
            }
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
        }


        protected override void DoQuery()
        {

            //CarInH o = new CarInH();
            //o.Supplier = txtSupplier.Text;
            //o.DH = txtDH.Text;
            //DataTable dt=mICarStock.GetCarInHsOfQuery(datBegin.Value.ToShortDateString(),datEnd.Value.ToShortDateString(),o);
            //FrmAssist.UpdateColumns(ref mDicOfCarInH, dt, 3);
            //dgCarInH.DataSource = dt;
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



            dt = mICarStock.GetCarInHsOfQuery(strBegin, strEnd, mLstE, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();
            DataToControl(dt);



            //  DataToControl(mICarStock.GetCarInHsOfQuery(strBegin, strEnd, null));

        }


        private void DataToControl(DataTable dt)
        {

            FrmAssist.UpdateColumns(ref mDicOfCarInH, dt, 3);
            dgCarInH.DataSource = dt;

        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {
            if (dgCarInH.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgCarInH.SelectedRows[0];
                string strdh = seldr.Cells[1].Value.ToString();

                frmCarInH frm = new frmCarInH();
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
            frmCarInH frm = new frmCarInH();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                DoQuery();

            });
            frm.ShowDialogEx();
        }

        private void chbIsDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsDate.Checked)
            {
                datBegin.Enabled = true;
                datEnd.Enabled = true;
            }
            else
            {
                datBegin.Enabled = false;
                datEnd.Enabled = false;
            }
        }


        private void btnCustomerFind_Click(object sender, EventArgs e)
        {
            frmSupplyUnit frm = new frmSupplyUnit();
            frm.ShowDialogEx();

        }
    }
}
