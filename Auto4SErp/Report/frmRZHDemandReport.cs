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
    public partial class frmRZHDemandReport : ifrmBase
    {
        private IAccessory mIAccessory;
        public frmRZHDemandReport()
        {
            InitializeComponent();
            mIAccessory = Bll.BllFactory.GetAccessoryBll();
        }

        private void frmRZHDemandReport_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "/" + dtNow.Month + "/01 00:00");
            txtDate.SelectedIndex = 0;
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



            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";


            dgOutWareRec.AutoGenerateColumns = false;
            DataTable dt = mIAccessory.GetZHDemandsDetails(txtDate.SelectedIndex, strBegin, strEnd);
            dgOutWareRec.DataSource = dt;

            decimal zhje = mIAccessory.GetZHJEOfQuery(txtDate.SelectedIndex, strBegin, strEnd);
            decimal suminprice = dt.AsEnumerable().Sum(r => (decimal.Parse(r[6].ToString())));
            decimal sumsaleprice = dt.AsEnumerable().Sum(r => (decimal.Parse(r[8].ToString())));
            lblSum.Text = string.Format("总数量:{0},总金额:{1},随车装潢:{2}", suminprice, sumsaleprice, zhje);

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            ExcelInAndOut eio = new ExcelInAndOut("");

            eio.NewDTOutTo(dgOutWareRec);
        }
    }
}
