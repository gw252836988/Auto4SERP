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
using Comm;
using Auto4SErp.Sale;


namespace Auto4SErp.Report
{
    public partial class frmRCarAverage : ifrmBase
    {
        private ICarSale mICarSale;
        public frmRCarAverage()
        {
            mICarSale = BllFactory.GetCarSaleBll();
            InitializeComponent();
        }

        private void frmRCarAverage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                cmbMonth.Items.Add((i + 1) + "月");
            }
            int month = DateTime.Now.Month;
            cmbMonth.SelectedIndex = month - 1;
            SetTButtonPng(toolStrip1);
            cmbYear.Text = DateTime.Now.Year.ToString();
        }

        protected override void DoQuery()
        {
            int year = int.Parse(cmbYear.Text);
            int month;
            string strBegin = "";
            string strEnd = "";
            if (chbIsDate.Checked)
            {
                strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            }
            month = cmbMonth.SelectedIndex + 1;
            DataTable dt = mICarSale.GetCarAveragePrice(strBegin, strEnd, year, month);
            dgCarSale.DataSource = dt;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            ExcelInAndOut eio = new ExcelInAndOut("");
            //eio.Title = "维修查询";
            DataTable dt = dgCarSale.DataSource as DataTable;
            // Comm.ExcelInAndOut io = new Comm.ExcelInAndOut("");
            // dt.

            //eio.DTOutTo(dt,dgCarSale);
            eio.NewDTOutTo((DataGridView)dgCarSale);
        }
    }
}
