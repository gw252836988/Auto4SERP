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
using Auto4SErp.Repair;
using Comm;
namespace Auto4SErp.Report
{
    public partial class frmRAccidentReport : ifrmBase
    {
        private IRepair mIRepair;
        public frmRAccidentReport()
        {
            InitializeComponent();
            mIRepair = BllFactory.GetRepariBll();
        }

        private void frmRAccidentReport_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "/" + dtNow.Month + "/01 00:00");
            SetTButtonPng(toolStrip1);
            DoQuery();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        protected override void DoQuery()
        {
            string strBegin = "";
            string strEnd = "";

            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";




            // DataTable dt, dtSum;
            DataTable dt = mIRepair.GetAccidentProfits(strBegin, strEnd, itiminamount.Value, itimaxamount.Value, txtInsuranceCompany.Text, cmbComeType.Text);
            dgRepair.AutoGenerateColumns = false;
            dgRepair.DataSource = dt;

            decimal rate = 0;
            decimal gamout = 0;
            decimal ItemProfit = 0;
            decimal accprofit = 0;
            decimal GInprice = 0;
            decimal GProfit = 0;
            decimal YQCost = 0;
            if (dt.Rows.Count > 0)
            {


                //rate = dt.AsEnumerable().Sum(r => decimal.Parse(r["PRate"].ToString()));
                //rate = rate / (dt.Rows.Count);
                //rate = Math.Round(rate, 2);

                gamout = dt.AsEnumerable().Sum(r => decimal.Parse(r["gamount"].ToString()));
                ItemProfit = dt.AsEnumerable().Sum(r => decimal.Parse(r["ItemProfit"].ToString()));
                accprofit = dt.AsEnumerable().Sum(r => decimal.Parse(r["accprofit"].ToString()));
                GInprice = dt.AsEnumerable().Sum(r => decimal.Parse(r["GInprice"].ToString()));
                //GProfit = dt.AsEnumerable().Sum(r => decimal.Parse(r["GProfit"].ToString()));

                //if (gamout != 0)
                //    rate = (gamout - GInprice) / gamout;
                //else
                //    rate = 0;
                //rate = Math.Round(rate, 2);

                string organname = Comm.LoginInfoShare.getInstance().OrganName;
                string organid = Comm.LoginInfoShare.getInstance().OrganId;
                string staffname = "";

                if (organname.Contains("永兴"))
                    staffname = "('王洪兵')";
                else if (organid == "159" || organid == "160" || organid == "152" || organid == "153")
                {
                    staffname = "('蔡琴')";
                }
                else if (organname.Contains("如东"))
                {
                    staffname = "('姜伟伟')";
                }
                else if (organname.Contains("海门"))
                {
                    staffname = "('季小东')";
                }
                else if (organid == "161")
                {
                    staffname = "('赵升晟')";
                }
                else if (organid == "301")
                {
                    staffname = "('李桂荣','蔡军')";
                }
                else if (organid == "258")
                {
                    staffname = "('董志国')";
                }

                YQCost = mIRepair.GetYQCost(strBegin, strEnd, staffname, txtInsuranceCompany.Text, cmbComeType.Text);
                //YQCost = 0;

                GProfit = gamout - GInprice - YQCost;
                if (gamout != 0)
                    rate = GProfit / gamout;
                else
                    rate = 0;
                rate = Math.Round(rate, 2);

            }
            //gamout = Math.Round(gamout /1.17m,2);
            //ItemProfit = Math.Round(ItemProfit / 1.17m, 2);
            //accprofit = Math.Round(accprofit / 1.17m, 2);
            //GInprice = Math.Round(GInprice / 1.17m, 2);
            //YQCost = Math.Round(YQCost / 1.17m, 2);
            //GProfit = Math.Round(GProfit / 1.17m, 2);
            lblSum.Text = string.Format("结算金额合计:{0},项目费合计:{1},材料费合计:{2},材料成本合计:{3},油漆成本合计:{6},利润合计:{4},毛利率:{5}", gamout, ItemProfit, accprofit, GInprice, GProfit, rate, YQCost);
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            ExcelInAndOut eio = new ExcelInAndOut("");
            //eio.Title = "维修查询";
            // DataTable dt = dgRepair.DataSource as DataTable;
            // Comm.ExcelInAndOut io = new Comm.ExcelInAndOut("");
            // dt.

            //eio.DTOutTo(dt,dgCarSale);
            eio.NewDTOutTo((DataGridView)dgRepair);
        }

        private void dgRepair_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DrawGridID(e);
        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {
            if (dgRepair.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgRepair.SelectedRows[0];

                string dh = seldr.Cells["DH"].Value.ToString().Trim();


                frmRepair frm = new frmRepair();
                frm.DH = dh;
                frm.ShowDialogEx();

            }
        }
    }
}
