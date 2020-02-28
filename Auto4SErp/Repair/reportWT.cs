using System;
using System.Drawing;
using System.Data;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bll.Repair;
using Bll;
using Model;
namespace Auto4SErp.Repair
{
    public partial class reportWT : DevExpress.XtraReports.UI.XtraReport
    {


        private IRepair mIRepair;
        public DataTable ItemTable
        {
            get;
            set;

        }


        public string DH
        {

            get;
            set;

        }

        public Company CompanyInfo
        {
            get;
            set;
        }

        public string CarColor
        {
            get;
            set;

        }
        private string itemAmount;

        public reportWT()
        {

            InitializeComponent();

        }


        //维修项目明细

        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {



        }

        private void Detail1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            RepairM rep;
            mIRepair = BllFactory.GetRepariBll();
            rep = mIRepair.GetRepairByDH(DH);
            xrTableCell2.Text = rep.DH;
            xrTableCell4.Text = DateTime.Now.Year + "年";
            xrTableCell5.Text = DateTime.Now.Month + "月";
            xrTableCell6.Text = DateTime.Now.Day + "日";
            xrTableCell7.Text = DateTime.Now.Hour + "时";
            xrTableCell8.Text = DateTime.Now.Minute + "分";

            xrTableCell10.Text = rep.CustName;
            xrTableCell14.Text = rep.Mobile;

            xrTableCell12.Text = rep.SendRepMan;
            xrTableCell18.Text = rep.SendRepTel;

            xrTableCell29.Text = rep.PlateNum;
            xrTableCell31.Text = rep.CarModel;
            xrTableCell28.Text = rep.InMil;
            xrTableCell34.Text = rep.Vin;
            xrTableCell24.Text = CarColor;


            DateTime receptTime = DateTime.Parse(rep.ReceptTime);
            xrTableCell43.Text = receptTime.Year + "年";
            xrTableCell44.Text = receptTime.Month + "月";
            xrTableCell36.Text = receptTime.Day + "日";

            if (rep.EstimateComplete != null)
            {
                xrTableCell48.Text = rep.EstimateComplete.Year + "年";
                xrTableCell49.Text = rep.EstimateComplete.Month + "月";
                xrTableCell50.Text = rep.EstimateComplete.Day + "日";
            }
            itemAmount = rep.PreItemAmount;

        }

        private void Detail2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void DetailReport_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void Detail6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (CompanyInfo != null)
            {
                xrTableCell184.Text = CompanyInfo.CompanyName;
                xrTableCell187.Text = CompanyInfo.CompanyAddress;
                xrTableCell191.Text = CompanyInfo.TelePhone;
                xrTableCell193.Text = CompanyInfo.TelePhone;
                xrTableCell194.Text = CompanyInfo.TelePhone;
            }
        }

        private void Detail5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell82.Text = itemAmount;
        }

        private void DetailReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            DetailReportBand reportBand = (DetailReportBand)sender;
            // DataTable dt = CreateMainTable();
            reportBand.DataSource = ItemTable;



            XRBinding binding = new XRBinding("Text", reportBand.DataSource, "itemcode", "{0}");
            xrTableCell85.DataBindings.Add(binding);

            XRBinding binding1 = new XRBinding("Text", reportBand.DataSource, "itemName", "{0}");
            xrTableCell92.DataBindings.Add(binding1);

            XRBinding binding2 = new XRBinding("Text", reportBand.DataSource, "pricetype", "{0}");
            xrTableCell87.DataBindings.Add(binding2);

            XRBinding binding3 = new XRBinding("Text", reportBand.DataSource, "finalprice", "{0}");
            xrTableCell90.DataBindings.Add(binding3);

        }

    }
}
