using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using Bll.Repair;
using Comm;
namespace Auto4SErp.Report
{
    public partial class frmLoyalCustomer : ifrmBase
    {
        private IRepair mIRepair;
        public frmLoyalCustomer()
        {
            InitializeComponent();
            mIRepair = BllFactory.GetRepariBll();
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

            dgResult.DataSource = mIRepair.GetLoyalCustomers(strBegin, strEnd, itiCount.Value);


        }

        private void frmLoyalCustomer_Load(object sender, EventArgs e)
        {
            DoQuery();
            SetTButtonPng(toolStrip1);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            ExcelInAndOut eio = new ExcelInAndOut("");
            //eio.Title = "维修查询";

            eio.NewDTOutTo(dgResult);
        }

        private void dgResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgResult_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DrawGridID(e);
        }
    }
}
