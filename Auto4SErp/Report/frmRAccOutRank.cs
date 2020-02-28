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
namespace Auto4SErp.Report
{
    public partial class frmRAccOutRank : ifrmBase
    {

        // private List<SqlElement> mLstE;
        private IAccessory mIAccessory;
        public frmRAccOutRank()
        {
            InitializeComponent();
            mIAccessory = Bll.BllFactory.GetAccessoryBll();
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
            DataTable dt = mIAccessory.GetAccOutRank(cmbHouseName.Text, strBegin, strEnd, cmbInType.SelectedIndex, chbClaim.Checked, chbRepair.Checked);
            dgOutWareRec.DataSource = dt;
            decimal suminprice = dt.AsEnumerable().Sum(r => (decimal.Parse(r[4].ToString())));
            decimal sumsaleprice = dt.AsEnumerable().Sum(r => (decimal.Parse(r[5].ToString())));
            lblSum.Text = string.Format("总成本价:{0},总销售价{1}", suminprice, sumsaleprice);
        }

        private void FrmRAccOutRank_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "/" + dtNow.Month + "/01 00:00");
            LoadExtendContents("仓库名称", cmbHouseName);
            cmbHouseName.SelectedIndex = -1;
            SetTButtonPng(toolStrip1);
        }
    }
}
