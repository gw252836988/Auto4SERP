using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using Bll.Sale;
namespace Auto4SErp.Report
{
    public partial class frmRCarTORate : ifrmBase
    {

        private ICarSale mICarSale;
        public frmRCarTORate()
        {
            InitializeComponent();
            mICarSale = BllFactory.GetCarSaleBll();
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            dgResult.DataSource = CreateDataTable();
        }


        private DataTable CreateDataTable()
        {
            DataTable dtResult;
            dtResult = new DataTable();

            dtResult.Columns.Add("月份");
            dtResult.Columns.Add("出库量");
            dtResult.Columns.Add("期末库存");

            int currentmonth = DateTime.Now.Month;
            int g_carout = 0;
            int g_carstock = 0;
            int carout;
            int carstock;


            for (int i = 1; i < currentmonth; i++)
            {

                DataRow dr = dtResult.NewRow();
                dr[0] = i + "月";
                carout = mICarSale.GetCountOfCarOutInMonth(2016, i);
                carstock = mICarSale.GetCountOfCarStockInMonth(2016, i);
                dr[1] = carout;
                dr[2] = carstock;
                g_carout += carout;
                g_carstock += carstock;
                dtResult.Rows.Add(dr);

            }

            decimal torate = (g_carstock / (currentmonth - 1));
            torate = g_carout / torate;
            torate = Math.Round(torate, 2);
            txtTORate.Text = torate.ToString();


            return dtResult;


        }

        private void frmRCarTORate_Load(object sender, EventArgs e)
        {
            nudYear.Value = DateTime.Now.Year;
            SetTButtonPng(toolStrip1);
        }
    }
}
