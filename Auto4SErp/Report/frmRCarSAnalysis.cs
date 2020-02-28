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
    public partial class frmRCarSAnalysis : ifrmBase
    {
        private ICarSale mICarSale;
        public frmRCarSAnalysis()
        {
            InitializeComponent();
            mICarSale = BllFactory.GetCarSaleBll();

        }

        private void frmRCarSAnalysis_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                cmbMonth.Items.Add((i + 1) + "月");
            }
            int month = DateTime.Now.Month;
            cmbMonth.SelectedIndex = month - 1;
            SetTButtonPng(toolStrip1);
            cmbYear.Text = DateTime.Now.Year.ToString();
            DoQuery();
            AddYearsToCmb(cmbYear);
        }



        private void btnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }
        protected override void DoQuery()
        {
            int year = int.Parse(cmbYear.Text);
            int month;
            month = cmbMonth.SelectedIndex + 1;

            string strBegin = "";
            string strEnd = "";
            if (chbIsDate.Checked)
            {
                strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            }

            DataTable dt = mICarSale.GetCarAnalysis(strBegin, strEnd, year, month, txtSaler.Text, txtCarModel.Text);
            //dgCarSale.AutoGenerateColumns = false;
           // dgCarSale.DataSource = dt;
            gridCar_Sale.DataSource = dt;
            lblSum.Text = "数量:" + dt.Rows.Count.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Point pt = this.Location;
            Auto4SErp.Sale.frmDlgCarSuperSel frm = new Auto4SErp.Sale.frmDlgCarSuperSel();
            // Point NewPoint = new Point(pt.X + this.Width, pt.Y - 50);
            // frm.Location = NewPoint;
            frm.Layer = 2;
            frm.setTransferDelegate(new TransferDelegate(this.DoResultFromSuperSel));
            frm.ShowDialogEx();
        }
        private void DoResultFromSuperSel(object obj)
        {
            string result = (string)obj;
            string[] strtempl = result.Split('_');

            txtCarModel.Text = strtempl[2];

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //ExcelInAndOut eio = new ExcelInAndOut("");
            //DataTable dt = dgCarSale.DataSource as DataTable;
            //eio.NewDTOutTo((DataGridView)dgCarSale);

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {
   

            DataRowView obj = (DataRowView)gridView1.GetFocusedRow();
            if (obj != null)
            {
               
                frmCarSale frm = new frmCarSale();
                frm.DH = obj["DH"].ToString();
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                        DoQuery();


                });
                frm.ShowDialogEx();

            }
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
