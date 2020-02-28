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
namespace Auto4SErp.Report
{
    public partial class frmFStatistics : ifrmBase
    {
        private IFinance mIFinance;
        // private DataTable mDtDicOfAccount;
        private List<SqlElement> mLstE;
        public frmFStatistics()
        {
            mIFinance = BllFactory.GetFinanceBll();
            InitializeComponent();
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        protected override void DoQuery()
        {

            string strBegin = "";
            string strEnd = "";
            string items = "";


            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";



            mLstE = CreateMedialSqlElement(AssginToListOfQuery());

            if (chbDH.Checked == true) items = items + "DHFrom,";
            if (chbDescribes.Checked == true) items = items + "Describes,";
            //items = items + "DHFrom,";
            //items = items + "Describes,";
            if (items.Length > 0)
                items = items.Remove(items.Length - 1);

            DataTable dt = mIFinance.GetAccountStatistics(items, mLstE, strBegin, strEnd, cmbInType.SelectedIndex);
            //    FrmAssist.UpdateColumns(ref mDtDicOfAccount, dt, 10);

            ResultSum(dt);
            dgAccount.AutoGenerateColumns = false;
            dgAccount.DataSource = dt;

        }
        private void ResultSum(DataTable dt)
        {
            float g_amount = 0;
            float g_revamount = 0;
            float g_cash = 0;
            float g_vip = 0;
            float g_bank = 0;
            float g_p2p = 0;
            float g_cs = 0;
            float g_prerecv = 0;
            float g_other = 0;
            float g_invoiceamount = 0;
            float g_checkamount = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                g_cash = g_cash + float.Parse(dt.Rows[i][2].ToString());
                g_revamount = g_revamount + float.Parse(dt.Rows[i][1].ToString());
                g_bank = g_bank + float.Parse(dt.Rows[i][3].ToString());
                g_vip = g_vip + float.Parse(dt.Rows[i][4].ToString());
                g_p2p = g_p2p + float.Parse(dt.Rows[i][5].ToString());
                g_cs = g_cs + float.Parse(dt.Rows[i][6].ToString());
                g_other = g_other + float.Parse(dt.Rows[i][7].ToString());
                g_prerecv = g_prerecv + float.Parse(dt.Rows[i][8].ToString());
                g_invoiceamount = g_invoiceamount + float.Parse(dt.Rows[i][9].ToString());
                g_amount = g_amount + float.Parse(dt.Rows[i][0].ToString());
                g_checkamount = g_checkamount + float.Parse(dt.Rows[i][10].ToString());
            }
            DataRow dr = dt.NewRow();
            dr[2] = g_cash;

            dr[3] = g_bank.ToString("0.00");
            dr[4] = g_vip.ToString("0.00");
            dr[5] = g_p2p.ToString("0.00");
            dr[6] = g_cs.ToString("0.00");
            dr[7] = g_other.ToString("0.00");
            dr[8] = g_prerecv.ToString("0.00");
            dr[9] = g_invoiceamount.ToString("0.00");
            dr[0] = g_amount.ToString("0.00");
            dr[1] = g_revamount.ToString("0.00");
            dr[10] = g_checkamount.ToString("0.00");
            dt.Rows.Add(dr);

            //if (chbDescribes.Checked)
            //    dgAccount.Columns[0].Visible = true;
            //else
            //    dgAccount.Columns[0].Visible = false;

            //if (chbDH.Checked)
            //    dgAccount.Columns[1].Visible = true;
            //else
            //    dgAccount.Columns[1].Visible = false;
        }



        private void frmFStatistics_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "/" + dtNow.Month + "/01 00:00");
            mLstControls.Add(cmbDescribes);
            SetTButtonPng(toolStrip1);
            DoQuery();


             
        }

        private void chbDescribes_CheckValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Comm.ExcelInAndOut io = new Comm.ExcelInAndOut("");
            io.DTOutTo(dgAccount);
        }
    }
}
