using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bll.Repair;
using Bll;
using Model;
using System.Data;
namespace Auto4SErp.Repair
{
    public partial class reportJS : DevExpress.XtraReports.UI.XtraReport
    {

        private IRepair mIRepair;
        public DataTable ItemTable
        {
            get;
            set;

        }

        public DataTable AccTable
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

        public reportJS()
        {
            InitializeComponent();
        }

        private string PreItemAmount;
        private string PreAccessoryAmount;
        private string GAmount;
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

            PreItemAmount = rep.PreItemAmount;
            PreAccessoryAmount = rep.PreAccessoryAmount;
            GAmount = rep.GAmount.ToString();

        }

        private void Detail5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (CompanyInfo != null)
            {
                xrTableCell148.Text = CompanyInfo.CompanyName;
                xrTableCell155.Text = CompanyInfo.CompanyAddress;
                xrTableCell160.Text = CompanyInfo.TelePhone;
                xrTableCell158.Text = CompanyInfo.TelePhone;
                xrTableCell162.Text = CompanyInfo.TelePhone;
                xrTableCell170.Text = CompanyInfo.Bank;
                xrTableCell174.Text = CompanyInfo.CompanyName;
                xrTableCell181.Text = CompanyInfo.BankAccount;
            }

            xrTableCell82.Text = PreItemAmount;
            xrTableCell84.Text = PreAccessoryAmount;
            xrTableCell96.Text = GAmount;
            xrTableCell77.Text = PreItemAmount;
            xrTableCell62.Text = PreAccessoryAmount;
            xrTableCell108.Text = GAmount;
        }

        private void Detail2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void DetailReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (ItemTable == null) return;
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

        private void DetailReport3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (AccTable == null) return;
            DetailReportBand reportBand = (DetailReportBand)sender;
            // DataTable dt = CreateMainTable();
            reportBand.DataSource = AccTable;

            XRBinding binding = new XRBinding("Text", reportBand.DataSource, "accessorycode", "{0}");
            xrTableCell57.DataBindings.Add(binding);

            XRBinding binding1 = new XRBinding("Text", reportBand.DataSource, "accessoryname", "{0}");
            xrTableCell58.DataBindings.Add(binding1);

            XRBinding binding2 = new XRBinding("Text", reportBand.DataSource, "amount", "{0}");
            xrTableCell59.DataBindings.Add(binding2);

            XRBinding binding3 = new XRBinding("Text", reportBand.DataSource, "sum1", "{0}");
            xrTableCell60.DataBindings.Add(binding3);

        }

    }
}
