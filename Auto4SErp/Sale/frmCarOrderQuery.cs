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
    public partial class frmCarOrderQuery : ifrmBase
    {
        private ICarSale mICarSale;

        private List<SqlElement> mLstE;

        public bool IsSelect
        {
            get;
            set;
        }
        private bool mIsOut = false;
        public frmCarOrderQuery()
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
            //mLstE = new List<SqlElement>();
            //mLstE.Add(new SqlElement() { Name = "DH", Value = txtDH.Text, IsFuzzy = true, IsStr = true });
            //mLstE.Add(new SqlElement() { Name = "Mobile", Value = txtMobile.Text, IsFuzzy = true, IsStr = true });
            //mLstE.Add(new SqlElement() { Name = "CustName", Value = txtCustName.Text, IsFuzzy = true, IsStr = true });

            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
            // DataTable dt = mICarSale.GetCarOrdersByQuery(datBegin.Value.ToShortDateString(), datEnd.Value.ToShortDateString(), mLstE);
            //DataToControl(dt);
        }


        private void DataToControl(DataTable dt)
        {

            //  FrmAssist.UpdateColumns(ref mDicOfCustomer, dt, 2);
            // FrmAssist.UpdateColumns(ref mDicOfCarOrder, dt, 8);
            dgCarOrder.AutoGenerateColumns = false;
            dgCarOrder.DataSource = dt;

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

            string salename;
            string str = Comm.LoginInfoShare.getInstance().PositionName;
            if (Comm.LoginInfoShare.getInstance().PositionName == "销售顾问")
                salename = Comm.LoginInfoShare.getInstance().UserName;
            else
                salename = "";

            if (mIsOut)
            {
                Comm.ExcelInAndOut io = new Comm.ExcelInAndOut("");
                DataTable dtout = mICarSale.GetOutCarOrdersByQuery(strBegin, strEnd, IsSelect, mLstE, salename);
                io.DTOutTo(dtout, dgCarOrder);
                mIsOut = false;
                return;
            }
            dt = mICarSale.GetCarOrdersByQuery(strBegin, strEnd, IsSelect, mLstE, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount, salename);
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();
            DataToControl(dt);



        }

        private void dgCarOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsSelect)
            {
                if (dgCarOrder.SelectedRows.Count != 0)
                {
                    DataGridViewRow seldr = dgCarOrder.SelectedRows[0];
                    string dh = seldr.Cells["dh"].Value.ToString();
                    string autonumer = seldr.Cells["AutoNumber"].Value.ToString();
                    string mobile = seldr.Cells["mobile"].Value.ToString();
                    string saleprice = seldr.Cells["saleprice"].Value.ToString();
                    string result = dh + "," + mobile + "," + autonumer + "," + saleprice;
                    if (m_del != null)
                    {
                        m_del(result);
                    }
                    this.Close();
                }
            }
        }

        private void frmCarOrderQuery_Load(object sender, EventArgs e)
        {

            mLstControls.Add(txtDH);
            mLstControls.Add(txtMobile);
            mLstControls.Add(txtCustName);
            //   mLstControls.Add(cmbStatus);

            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            //mLstE = new List<SqlElement>();
            //mLstE.Add(new SqlElement() { Name = "Status", Value = "0", IsFuzzy = false, IsStr = false });
            //cmbStatus.SelectedIndex = 0;

            if (IsSelect)
            {
                tbtbAdd.Visible = false;
                tbtbOpen.Visible = false;

            }
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
            SetTButtonPng(toolStrip1);
        }

        private void tbtbAdd_Click(object sender, EventArgs e)
        {
            frmCarOrder frm = new frmCarOrder();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                DoQuery();

            });
            frm.ShowDialogEx();
        }

        private void tbtbOpen_Click(object sender, EventArgs e)
        {
            if (dgCarOrder.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgCarOrder.SelectedRows[0];
                string strbh = seldr.Cells[0].Value.ToString();

                frmCarOrder frm = new frmCarOrder();
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                        DoQuery();

                });
                frm.DH = strbh;
                frm.ShowDialogEx();
            }
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

        private void btnOut_Click(object sender, EventArgs e)
        {
            mIsOut = true;
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
        }
    }
}
