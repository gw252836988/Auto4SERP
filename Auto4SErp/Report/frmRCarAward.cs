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
using Bll.Personnel;
using Bll.Repair;
using Auto4SErp.Sale;
namespace Auto4SErp.Report
{
    public partial class frmRCarAward : ifrmBase
    {
        private ICarSale mICarSale;
        private IRepair mIRepair;
        private IFucntion mIFunction;
        public  DataTable mDt;
        private DataTable mAwardDt;
        private List<SaleAward> mListAwards;
        private IExtend mIExtend;
        public frmRCarAward()
        {
            mICarSale = BllFactory.GetCarSaleBll();
            mIFunction = BllFactory.GetFunctionBll();
            mIRepair = BllFactory.GetRepariBll();
            mIExtend = BllFactory.GetExtendBll();
            InitializeComponent();
        }

        private void frmRCarAward_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                cmbMonth.Items.Add((i + 1) + "月");
            }
            int month = DateTime.Now.Month;
            cmbMonth.SelectedIndex = month - 1;
            SetTButtonPng(toolStrip1);
            cmbYear.Text = DateTime.Now.Year.ToString();
            mAwardDt = mIFunction.GetAwards();
            GenerateList();
            AddYearsToCmb(cmbYear);
        }




        private void GenerateList()
        {
            if (mAwardDt != null)
            {
                mListAwards = new List<SaleAward>();
                for (int i = 0; i < mAwardDt.Rows.Count; i++)
                {

                    SaleAward obj = new SaleAward();
                    obj.Carser = mAwardDt.Rows[i]["CarSer"].ToString();
                    obj.CarModel = mAwardDt.Rows[i]["CarModel"].ToString();
                    obj.Award = decimal.Parse(mAwardDt.Rows[i]["Award"].ToString());
                    mListAwards.Add(obj);

                }


            }



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

            string positionname = Comm.LoginInfoShare.getInstance().PositionName;
            string saler = Comm.LoginInfoShare.getInstance().UserName;


            mDt = mICarSale.GetCarSalesOfMonth(strBegin, strEnd, year, month, txtSaler.Text, txtCarSer.Text);

            // gridReward.DataSource = mDt;
            //dgCarSale.AutoGenerateColumns = false;
            CaculateAward();



        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        private void btnCalulate_Click(object sender, EventArgs e)
        {




        }


        private void CaculateAward()
        {


            if (mListAwards != null && mListAwards.Count > 0)
            {
                GenerateList();
            }
            if (mDt != null)
            {
                for (int i = 0; i < mDt.Rows.Count; i++)
                {

                    string carser = "";
                    string carmodel = "";
                    string saletype = "";
                    string saleman = "";
                    decimal ServiceReward = 0;
                    decimal DecorateReward = 0;
                    decimal InsuranceReward = 0;
                    decimal ChangeReward = 0;
                    decimal LoanReward = 0;
                    decimal DecorateAward = 0;
                    decimal gamount = 0;//收款装潢
                    decimal award;
                    decimal greward = 0;
                    string dh;

                    carser = mDt.Rows[i]["CarSer"].ToString();
                    carmodel = mDt.Rows[i]["CarModel"].ToString();
                    saletype = mDt.Rows[i]["SaleType"].ToString();
                    saleman = mDt.Rows[i]["SaleMan"].ToString();
                    gamount = decimal.Parse(mDt.Rows[i]["gamount"].ToString());
                    ChangeReward = decimal.Parse(mDt.Rows[i]["ChangeReward"].ToString());
                    LoanReward = decimal.Parse(mDt.Rows[i]["LoanReward"].ToString());
                    DecorateAward = decimal.Parse(mDt.Rows[i]["DecorateAward"].ToString());
                    InsuranceReward = decimal.Parse(mDt.Rows[i]["InsuranceReward"].ToString());
                    dh = mDt.Rows[i]["DH"].ToString();
                    ServiceReward = decimal.Parse(mDt.Rows[i]["ServiceReward"].ToString());
                    if (ServiceReward < 0)
                        ServiceReward = 0;
                    mDt.Rows[i]["ServiceReward"] = ServiceReward;

                    //DecorateReward = mIRepair.GetProfitOfZh(dh);
                    //DecorateReward = 0;
                    //if (gamount > 0)
                    //{
                    //    DecorateReward = (gamount - DecorateReward) * ((decimal)0.08);
                    //    mDt.Rows[i]["DecorateReward"] = DecorateReward;
                    //}

                    SaleAward obj = mListAwards.Find(o => (o.Carser + o.CarModel).Trim() == (carser + carmodel).Trim());

                    if (obj != null)
                    {
                        award = obj.Award;
                    }
                    else
                        award = 0;
                    if (saletype == "二网" || saleman.Contains("二网"))
                    {
                        award = 20;
                        ServiceReward = 0;
                        DecorateReward = 0;
                        InsuranceReward = 0;
                        ChangeReward = 0;
                        LoanReward = 0;
                        DecorateAward = 0;
                    }
                    mDt.Rows[i]["award"] = award;

                    greward = award + ServiceReward + DecorateReward + InsuranceReward + ChangeReward + LoanReward + DecorateAward;
                    mDt.Rows[i]["greward"] = greward;

                   if (LoginInfoShare.getInstance().PositionName.Contains("人事"))
                   {
                       if (mDt.Rows[i]["IsPass"].ToString() == "0")
                           mDt.Rows[i]["award"] = 0;

                   }
                }

                // dgCarSale.DataSource = mDt;
                handleSubsaleway();
                gridReward.DataSource = mDt;
               
            }
        }



        private void SpecialDeal()
        {
            

              





        }



        private void handleSubsaleway()
        {

           // var q = mDt.AsEnumerable().Where(r => r["SaleMan"].ToString().Contains("二网") || r["SaleType"].ToString().Contains("二网"));

            for (int i = 0; i < mDt.Rows.Count; i++)
            {
                if (mDt.Rows[i]["SaleMan"].ToString().Contains("二网") || mDt.Rows[i]["SaleType"].ToString().Contains("二网"))
                {
                    mDt.Rows[i]["ChangeReward"] = "0";
                    mDt.Rows[i]["LoanReward"] = "0";
                    mDt.Rows[i]["DecorateAward"] = "0";
                    mDt.Rows[i]["InsuranceReward"] = "0";
                    mDt.Rows[i]["ServiceReward"] = "0";

                }



            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmBatchIn frm = new frmBatchIn();
            frm.TableName = "SaleAward";
            frm.ShowDialog();
        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {


            if (bandedGridView1.SelectedRowsCount > 0)
            {
                //DataGridViewRow seldr = dgCarSale.SelectedRows[0];
                //string strdh = seldr.Cells["DH"].Value.ToString();
                int selectedHandle;
                selectedHandle = this.bandedGridView1.GetSelectedRows()[0];

                string strdh = this.bandedGridView1.GetRowCellValue(selectedHandle, "DH").ToString();
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
            bandedGridView1.ExportToXls(dialog.FileName);
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            //if (dgSummary.Visible == true)
            //{
            //    dgSummary.Visible = false;
            //    return;
            //}
            //if (mDt != null && mDt.Rows.Count > 0)
            //{
            //    dgSummary.Visible = true;
            //    var summaryDt = mDt.AsEnumerable().GroupBy(m => m["SaleMan"]).Select(k => new { gService = k.Sum(l => decimal.Parse(l["ServiceReward"].ToString())), gWorkman = k.Max(l => l["SaleMan"]), gCount = k.Count(), gAward = k.Sum(l => decimal.Parse(l["Award"].ToString())), gLoan = k.Sum(l => decimal.Parse(l["LoanReward"].ToString())), gChange = k.Sum(l => decimal.Parse(l["ChangeReward"].ToString())) }).ToList();
            //    dgSummary.AutoGenerateColumns = false;
            //    dgSummary.DataSource = summaryDt;
            //}

            mIExtend.AddKeyLog(Comm.LoginInfoShare.getInstance().UserId, "计算装潢奖励");


            string dh;
            string vin;
            decimal PresentDecorPrice;
            if (mDt != null && mDt.Rows.Count > 0)
            {
                for (int i = 0; i < mDt.Rows.Count; i++)
                {
                    dh = mDt.Rows[i]["DH"].ToString();
                    vin = mDt.Rows[i]["Vin"].ToString();
                    PresentDecorPrice =decimal.Parse( mDt.Rows[i]["PresentDecorPrice"].ToString());
                    mIRepair.CalculateDecorateCost(dh, vin, PresentDecorPrice);
                }
                DoQuery();
            }

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {


        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnPass_Click(object sender, EventArgs e)
        {
           // string sql = "update set isPass=1 where  ";

            if (LoginInfoShare.getInstance().PositionName == "销售经理")
            {
                int handle = bandedGridView1.FocusedRowHandle;
                if (handle >= 0)
                {
                    string dh = bandedGridView1.GetRowCellValue(handle, "DH").ToString();
                    mICarSale.CarSaleRwardToggle(1, dh);

                    DoQuery();
                }
            }
            else
                // DevExpress.XtraEditors.XtraMessageBox.Show("只有销售经理才有此权限");    
                ShowMessage("只有销售经理才有此权限");
            }

        private void bandedGridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "IsPass")
            {

                string v = e.Value.ToString();

                if (v == "1")
                    e.DisplayText = "已审核";
                else
                    e.DisplayText = "未审核";

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (LoginInfoShare.getInstance().PositionName == "销售经理")
            {
                int handle = bandedGridView1.FocusedRowHandle;
                if (handle >= 0)
                {
                    string dh = bandedGridView1.GetRowCellValue(handle, "DH").ToString();

                    mICarSale.CarSaleRwardToggle(0, dh);
                    DoQuery();
                }
            }
            else
                ShowMessage("只有销售经理才有此权限");
        }
    }
}
