using System;
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
    public partial class frmDevCarSaleQuery : ifrmBase
    {
        private ICarSale mICarSale;
        //private DataTable mDicOfCarDoc;
        //private DataTable mDicOfCustomer;
        //private DataTable mDicOfCarSale;
        private List<SqlElement> mLstE;
        private int status = -1;
        private bool isSelect = false;

        public bool IsSelect
        {
            get { return isSelect; }
            set { isSelect = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public frmDevCarSaleQuery()
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


        private void DataToControl(DataTable dt)
        {
            //FrmAssist.UpdateColumns(ref mDicOfCarDoc, dt, 1);
            //FrmAssist.UpdateColumns(ref mDicOfCustomer, dt, 2);
            //FrmAssist.UpdateColumns(ref mDicOfCarSale, dt, 7);
            dgCarSale.DataSource = dt;



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
                strBegin = datBegin.Text + " 00:00:00";
                strEnd = datEnd.Text + " 23:59:59";
               
            }


            dt = mICarSale.GetCarSalesByQuery(strBegin, strEnd, mLstE, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            DataToControl(dt);
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<Pair> lst = AssginToListOfQuery();
            mLstE = CreateMedialSqlElement(lst);
            DoQuery();
        }

        private void frmDevCarSaleQuery_Load(object sender, EventArgs e)
        {
          //  datBegin.Text = DateTime.Now.ToShortDateString();
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            mLstControls.Add(txtCustName);
            mLstControls.Add(txtMobile);
            mLstControls.Add(cmbStatus);
            mLstControls.Add(txtDH);
            mLstControls.Add(txtSaleMan);
            mLstControls.Add(txtVin);

        }
    }
}
