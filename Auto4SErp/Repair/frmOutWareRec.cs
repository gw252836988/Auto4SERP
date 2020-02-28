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
    public partial class frmOutWareRec : ifrmBase
    {

        private List<SqlElement> mLstE = null;
        private IAccessory mIAccessory;
        public frmOutWareRec()
        {
            InitializeComponent();
            mIAccessory = BllFactory.GetAccessoryBll();

            tsbFirst = bindingNavigatorMoveFirstItem;
            tsbLast = bindingNavigatorMoveLastItem;
            tsbPre = bindingNavigatorMovePreviousItem;
            tsbNext = bindingNavigatorMoveNextItem;
            tstbPageCount = bindingNavigatorCountItem;
            tstbPageCurrent = bindingNavigatorPositionItem;
            tstbRecordCount = bindingNavigatorRecordCount;
        }

        private void frmOutWareRec_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtAccessoryName);
            mLstControls.Add(txtAccessoryCode);
            mLstControls.Add(cmbHouseName);
            mLstControls.Add(cmbOutReason);
            mLstControls.Add(cmbOutToUnit);
            mLstControls.Add(txtSmallType);
            mLstControls.Add(txtPlateNum);
            mLstControls.Add(txtDHFrom);
            mPageInfo.PageSize = 200;
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            DoQuery();
            LoadExtendContents("仓库名称", cmbHouseName);
            LoadExtendContents("出库方式", cmbOutReason);
            cmbHouseName.SelectedIndex = -1;
            cmbOutReason.SelectedIndex = -1;
            SetTButtonPng(toolStrip1);
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


            dt = mIAccessory.GetOutWareRecs(strBegin, strEnd, mLstE, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount, IsShow.Checked, chbIsPC.Checked);
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();


            DataTable sumdt = mIAccessory.GetSumOutWareRecs(strBegin, strEnd, mLstE, chbIsPC.Checked);
            double sumprice = double.Parse(Comm.ElseUtil.ReturnZero(sumdt.Rows[0][1].ToString()));
            sumprice = Math.Round(sumprice, 2);
            lblSum.Text = string.Format("合计  数量:{0}  成本金额:{1}  销售金额:{2}", Comm.ElseUtil.ReturnZero(sumdt.Rows[0][0].ToString()), sumprice, String.Format("{0:F}", Comm.ElseUtil.ReturnZero(sumdt.Rows[0][2].ToString())));
            if (IsShow.Checked)
            {
                Vin.Visible = true;
                CustName.Visible = true;
                OutToUnit.Visible = true;
                SupplyUnit.Visible = true;
                PlateNum.Visible = true;

            }
            else
            {
                Vin.Visible = false;
                CustName.Visible = false;
                OutToUnit.Visible = false;
                SupplyUnit.Visible = false;
                PlateNum.Visible = false;
            }
            DataToControl(dt);

        }

        private void DataToControl(DataTable dt)
        {

            // FrmAssist.UpdateColumns(ref mDicOfCarInH, dt, 3);
            //   dgOutWareRec.AutoGenerateColumns = false;
            //  SumResult(dt);
            dgOutWareRec.AutoGenerateColumns = false;
            dgOutWareRec.DataSource = dt;



        }

        private void SumResult(DataTable dt)
        {
            DataRow dr = dt.NewRow();
            float g_amount = 0;
            float g_inprice = 0;
            float g_saleprice = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                g_amount += float.Parse(dt.Rows[i]["amount"].ToString());
                g_inprice += float.Parse(dt.Rows[i]["inprice"].ToString());
                g_saleprice += float.Parse(dt.Rows[i]["saleprice"].ToString());
            }
            dr["AccessoryCode"] = "总计";
            dr["amount"] = g_amount.ToString();
            dr["inprice"] = g_inprice.ToString();
            dr["saleprice"] = g_saleprice.ToString();
            dt.Rows.Add(dr);

        }
        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());

            string strBegin = "";
            string strEnd = "";
            if (chbIsDate.Checked)
            {
                strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            }
            DataTable dt = mIAccessory.GetOutDtOfWareRecs(strBegin, strEnd, mLstE, IsShow.Checked);
            Comm.ExcelInAndOut io = new Comm.ExcelInAndOut("");
            io.DTOutTo(dt, dgOutWareRec);
        }

        private void IsShow_CheckValueChanged(object sender, EventArgs e)
        {
            if (IsShow.Checked)
            {
                cmbOutToUnit.Enabled = true;
                txtPlateNum.Enabled = true;

            }
            else
            {
                cmbOutToUnit.Enabled = false;
                txtPlateNum.Enabled = false;



            }
            cmbOutToUnit.Text = "";
            txtPlateNum.Text = "";

        }

        private void dgOutWareRec_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DrawGridID(e);
        }
    }
}
