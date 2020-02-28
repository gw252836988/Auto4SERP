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
    public partial class frmRRepReport : ifrmBase
    {
        private IRepair mIRepair;
        public frmRRepReport()
        {
            InitializeComponent();
            mIRepair = BllFactory.GetRepariBll();
        }

        private void frmRRepReport_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                cmbMonth.Items.Add((i + 1) + "月");
            }
            int month = DateTime.Now.Month;
            cmbMonth.SelectedIndex = month - 1;
            SetTButtonPng(toolStrip1);
            cmbYear.Text = DateTime.Now.Year.ToString();
            cmbRepChildType.Items.Add("一般维修");
            cmbRepChildType.Items.Add("事故维修");
            cmbRepChildType.Items.Add("总成大修");
            cmbRepChildType.Items.Add("免费保养");
            cmbRepChildType.Items.Add("常规保养");
            cmbRepChildType.Items.Add("自费事故维修");
            cmbRepChildType.Items.Add("索赔");
            cmbRepChildType.Items.Add("PDI");
            cmbRepChildType.Items.Add("免费检测");
            DoQuery();
            AddYearsToCmb(cmbYear);
            //if (Comm.LoginInfoShare.getInstance().PositionName == "销售顾问")
        }


        protected override void DoQuery()
        {
            int year = 0;
            int month;
            string strBegin = "";
            string strEnd = "";
            if (chbIsDate.Checked)
            {
                strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            }
            else
            {
                year = int.Parse(cmbYear.Text);
            }

            month = cmbMonth.SelectedIndex + 1;
            DataTable dt;

            dt = mIRepair.GetRepProfits(strBegin, strEnd, year, month, chbIsSG.Checked, cmbRepChildType.Text, txtReceptMan.Text, chbZH.Checked, txtPlateNum.Text);
            //dgRepair.DataSource = dt;
            gridRepair.DataSource = dt;
            decimal rate = 0;
            decimal gamout = 0;
            decimal ItemProfit = 0;
            decimal accprofit = 0;
            decimal GInprice = 0;
            decimal GProfit = 0;
            decimal YQCost = 0;
            decimal AccessAmount = 0;
            decimal Gje;
            // dtSum = mIRepair.GetSumOfRepProfits(strBegin, strEnd, year, month,chbIsSG.Checked);
            if (dt.Rows.Count > 0)
            {



                //rate = dt.AsEnumerable().Sum(r => decimal.Parse(Comm.ElseUtil.ReturnZero(r["PRate"].ToString())));
                //rate = rate / (dt.Rows.Count);
                //rate = Math.Round(rate,2);

                gamout = dt.AsEnumerable().Sum(r => decimal.Parse(Comm.ElseUtil.ReturnZero(r["gamount"].ToString())));
                ItemProfit = dt.AsEnumerable().Sum(r => decimal.Parse(Comm.ElseUtil.ReturnZero(r["ItemProfit"].ToString())));
                accprofit = dt.AsEnumerable().Sum(r => decimal.Parse(Comm.ElseUtil.ReturnZero(r["accprofit"].ToString())));
                GInprice = dt.AsEnumerable().Sum(r => decimal.Parse(Comm.ElseUtil.ReturnZero(r["GInprice"].ToString())));
                AccessAmount = dt.AsEnumerable().Sum(r => decimal.Parse(Comm.ElseUtil.ReturnZero(r["AccessAmount"].ToString())));
                // GProfit = dt.AsEnumerable().Sum(r => decimal.Parse(Comm.ElseUtil.ReturnZero(r["GProfit"].ToString())));

                // dt.AsEnumerable().GroupBy(r => r["DH"]).Select(k => new { ga = k.Sum(l => decimalConvert(l["gamount"])) });

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
                //else if (organid == "258")
                //{
                //    staffname = "('董志国')";
                //}


                if (chbZH.Checked)
                {
                    lblSum.Text = "";
                    return;
                }

                YQCost = mIRepair.GetYQCost1(strBegin, strEnd, staffname, year, month, chbIsSG.Checked, cmbRepChildType.Text, txtReceptMan.Text);

                Gje = gamout + AccessAmount;
                GProfit = gamout + AccessAmount - GInprice - YQCost;
                if (Gje != 0)
                    rate = GProfit / Gje;
                else
                    rate = 0;
                rate = Math.Round(rate, 2);


            }
            gamout = Math.Round(gamout / 1.13m, 2);
            ItemProfit = Math.Round(ItemProfit / 1.13m, 2);
            accprofit = Math.Round(accprofit / 1.13m, 2);
            GInprice = Math.Round(GInprice / 1.13m, 2);
            YQCost = Math.Round(YQCost / 1.13m, 2);
            GProfit = Math.Round(GProfit / 1.13m, 2);
            AccessAmount = Math.Round(AccessAmount / 1.13m, 2);

            lblSum.Text = string.Format("结算金额合计:{4},索赔通过金额:{7},项目费合计:{0},材料费合计:{1},材料成本合计:{2},油漆成本合计:{6},利润合计:{3},毛利率:{5}(不含税)", ItemProfit, accprofit, GInprice, GProfit, gamout, rate, YQCost, AccessAmount);


        }

        private decimal decimalConvert(object o)
        {
            return decimal.Parse(Comm.ElseUtil.ReturnZero(o.ToString()));
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        private void dgRepair_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DrawGridID(e);
        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {
           

            DataRowView obj = (DataRowView)gridView1.GetFocusedRow();
            if (obj != null)
            {
                string dh = obj["DH"].ToString();
                frmRepair frm = new frmRepair();
                frm.DH = dh;
                frm.ShowDialogEx();

            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            ExcelInAndOut eio = new ExcelInAndOut("");

            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Excel 文件(*.xls)|*.xls|Excel 文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            //以文件“*.xls”导出
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            gridView1.ExportToXls(dialog.FileName);
        }

        private void btnZHQuery_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
             e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
          if (e.Info.IsRowIndicator)
          {
            if (e.RowHandle >= 0)
            {
             e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
            else if (e.RowHandle < 0 && e.RowHandle > -1000)
           {
            e.Info.DisplayText = "G" + e.RowHandle.ToString();
            }
        }
        }
    }
}
