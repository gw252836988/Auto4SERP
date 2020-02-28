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
using Comm;
using Auto4SErp.Sale;

namespace Auto4SErp.Report
{
    public partial class frmRCarSale : ifrmBase
    {
        private ICarSale mICarSale;
        //public bool IsSaler
        //{
        //    get;
        //    set;

        //}
        public frmRCarSale()
        {
            mICarSale = BllFactory.GetCarSaleBll();
            InitializeComponent();
        }

        private void frmRCarSale_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                cmbMonth.Items.Add((i + 1) + "月");
            }
            int month = DateTime.Now.Month;
            cmbMonth.SelectedIndex = month - 1;
            SetTButtonPng(toolStrip1);
            cmbYear.Text = DateTime.Now.Year.ToString();

            //if (Comm.LoginInfoShare.getInstance().PositionName == "销售顾问")
            //    IsSaler = true;

            DoQuery();
            AddYearsToCmb(cmbYear);
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
            DataTable dt;
            string positionname = Comm.LoginInfoShare.getInstance().PositionName;
            string saler = Comm.LoginInfoShare.getInstance().UserName;

            if (positionname == "销售顾问")
                dt = mICarSale.GetCarSalesOfMonth(strBegin, strEnd, year, month, saler, txtCarSer.Text);
            else
                dt = mICarSale.GetCarSalesOfMonth(strBegin, strEnd, year, month, txtSaler.Text, txtCarSer.Text);

            dgCarSale.AutoGenerateColumns = false;
            dgCarSale.DataSource = dt;
            //lblSum.Text ="数量:"+ dt.Rows.Count.ToString();

            decimal totalsum = dt.AsEnumerable().Sum(r => decimal.Parse(r[11].ToString()));
            decimal carsum = dt.AsEnumerable().Sum(r => decimal.Parse(r[12].ToString()));

            int secondeCount = dt.AsEnumerable().Count(r => r[1].ToString().IndexOf("二网") >= 0 || r[2].ToString().IndexOf("二网") >= 0);

            lblSum.Text = string.Format("数量:{0},二网:{3},展厅:{4},总价合计:{1},车价合计{2}", dt.Rows.Count, totalsum, carsum, secondeCount, dt.Rows.Count - secondeCount);
        }



        private void btnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            ExcelInAndOut eio = new ExcelInAndOut("");
            //eio.Title = "维修查询";
            // DataTable dt = dgCarSale.DataSource as DataTable;
            eio.NewDTOutTo(dgCarSale);
        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {
            if (dgCarSale.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgCarSale.SelectedRows[0];
                string strdh = seldr.Cells["DH"].Value.ToString();

                frmCarSale frm = new frmCarSale();
                frm.DH = strdh;
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                        DoQuery();


                });
                frm.ShowDialogEx();

            }
        }
    }
}
