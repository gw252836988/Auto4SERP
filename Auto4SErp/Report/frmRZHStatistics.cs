using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Bll.Repair;
using Comm;
namespace Auto4SErp.Report
{
    public partial class frmRZHStatistics : ifrmBase
    {
        private IAccessory mIAccessory;
        public frmRZHStatistics()
        {
            InitializeComponent();
            mIAccessory = Bll.BllFactory.GetAccessoryBll();
        }

        private void frmRZHStatistics_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "/" + dtNow.Month + "/01 00:00");
            LoadExtendContents("仓库名称", cmbHouseName);
            cmbHouseName.SelectedIndex = -1;
            SetTButtonPng(toolStrip1);
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        protected override void DoQuery()
        {
            string strBegin = "";
            string strEnd = "";


            if (chbIsDate.Checked)
            {
                strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";
            }

            dgOutWareRec.AutoGenerateColumns = false;
            DataTable dt = mIAccessory.GetZHOutDetails(cmbHouseName.Text, strBegin, strEnd);
            dgOutWareRec.DataSource = dt;

            ///decimal zhje = mIAccessory.GetZHJEOfQuery(strBegin, strEnd);
            decimal suminprice = dt.AsEnumerable().Sum(r => (decimal.Parse(r[4].ToString())));
            decimal sumsaleprice = dt.AsEnumerable().Sum(r => (decimal.Parse(r[5].ToString())));
            decimal inprice = dt.AsEnumerable().Sum(r => (decimal.Parse(r[6].ToString())));
            lblSum.Text = string.Format("总数量:{0},总销售价:{1},总成本价:{2}", suminprice, sumsaleprice, inprice);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            ExcelInAndOut eio = new ExcelInAndOut("");

            eio.NewDTOutTo(dgOutWareRec);
        }
    }
}
