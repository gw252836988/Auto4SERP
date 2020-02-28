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
    public partial class frmInWareRec : ifrmBase
    {
        private List<SqlElement> mLstE = null;
        private IAccessory mIAccessory;
        private IExtend mIExtend;
        public frmInWareRec()
        {
            InitializeComponent();
            mIAccessory = BllFactory.GetAccessoryBll();
            mIExtend = BllFactory.GetExtendBll();
            tsbFirst = bindingNavigatorMoveFirstItem;
            tsbLast = bindingNavigatorMoveLastItem;
            tsbPre = bindingNavigatorMovePreviousItem;
            tsbNext = bindingNavigatorMoveNextItem;
            tstbPageCount = bindingNavigatorCountItem;
            tstbPageCurrent = bindingNavigatorPositionItem;
            tstbRecordCount = bindingNavigatorRecordCount;
        }

        private void frmInWareRec_Load(object sender, EventArgs e)
        {

            mLstControls.Add(txtAccessoryName);
            mLstControls.Add(txtAccessoryCode);
            mLstControls.Add(cmbInReason);
            mLstControls.Add(cmbHouseName);
            mLstControls.Add(cmbSupplyUnit);
            mPageInfo.PageSize = 200;
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            DoQuery();
            LoadExtendContents("入库方式", cmbInReason);
            LoadExtendContents("仓库名称", cmbHouseName);
            DataTable dt;
            dt = mIExtend.GetSupplyUnits("售后");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbSupplyUnit.Items.Add(dt.Rows[i][1].ToString());
            }
            cmbInReason.SelectedIndex = -1;
            cmbHouseName.SelectedIndex = -1;
            SetTButtonPng(toolStrip1);
        }

        protected override void DoQuery()
        {
            DataTable dt;
            string strBegin = "";
            string strEnd = "";
            //int tmpRecordCount;
            // int tmpPageCount; 

            if (chbIsDate.Checked)
            {
                strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            }


            dt = mIAccessory.GetInWareRecs(strBegin, strEnd, mLstE);
            //mPageInfo.RecordCount = tmpRecordCount;
            // mPageInfo.PageCount = tmpPageCount;

            // SetRoleNavigatorState();

            //   DataTable sumdt= mIAccessory.GetSumOutWareRecs(strBegin, strEnd, mLstE);

            DataTable sumdt = mIAccessory.GetInWareRecsSum(strBegin, strEnd, mLstE);
            lblSum.Text = string.Format("合计  数量:{0}  成本金额:{1}  ", sumdt.Rows[0][0].ToString(), sumdt.Rows[0][1].ToString());
            DataToControl(dt);


        }

        private void DataToControl(DataTable dt)
        {

            // FrmAssist.UpdateColumns(ref mDicOfCarInH, dt, 3);
            dgInWareRec.AutoGenerateColumns = false;
            // SumResult(dt);
            dgInWareRec.DataSource = dt;

        }


        private void SumResult(DataTable dt)
        {
            DataRow dr = dt.NewRow();
            float g_amount = 0;
            float g_inprice = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                g_amount += float.Parse(dt.Rows[i]["amount"].ToString());
                g_inprice += float.Parse(dt.Rows[i]["inprice"].ToString());
            }
            dr["AccessoryCode"] = "总计";
            dr["amount"] = g_amount.ToString();
            dr["inprice"] = g_inprice.ToString();
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
            DataTable dt;
            if (chbIsDate.Checked)
            {
                strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            }
            dt = mIAccessory.GetInDtOfWareRecs(strBegin, strEnd, mLstE);
            Comm.ExcelInAndOut io = new Comm.ExcelInAndOut("");
            io.DTOutTo(dt, dgInWareRec);
        }
    }
}
