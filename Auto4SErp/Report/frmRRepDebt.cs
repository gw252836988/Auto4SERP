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



namespace Auto4SErp.Report
{
    public partial class frmRRepDebt : ifrmBase
    {
        private List<SqlElement> mLstE;
        private IFinance mIFinance;


        public frmRRepDebt()
        {
            InitializeComponent();
            mIFinance = BllFactory.GetFinanceBll();

            ;
        }

        private void frmRRepDebt_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            //mLstE = new List<SqlElement>();
            //mLstE.Add(new SqlElement(){Name="Status",Value="0",IsFuzzy=false,IsStr=false});

            cmbDateType.SelectedIndex = 0;

            SetTButtonPng(toolStrip1);
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
        }


        protected override void DoQuery()
        {
            DataTable dt;
            string strBegin = "";
            string strEnd = "";
            int datetype = 0;
            decimal g1;
            decimal g2;
            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            datetype = cmbDateType.SelectedIndex;

            //if (mLstE != null)
            //{
            //    if (mLstE.Count > 0)
            //    {
            dt = mIFinance.GetAccountsOfDebt(strBegin, strEnd, mLstE, datetype);

            DataToControl(dt);
            //        return;
            //    }
            //}
            g1 = dt.AsEnumerable().Where(r => r["Status"].ToString() == "未收款").Sum(r => decimal.Parse(r["Amount"].ToString()));
            g2 = dt.AsEnumerable().Where(r => r["Status"].ToString() == "已收款").Sum(r => decimal.Parse(r["Amount"].ToString()));
            //   DataToControl(mIFinance.GetAccounts(strBegin, strEnd, null, datetype));
            lblSum.Text = string.Format("未收款合计:{0},已收款合计:{1}", g1, g2);
        }


        private void DataToControl(DataTable dt)
        {

            //FrmAssist.UpdateColumns(ref mDtDicOfCustomer, dt, 2);
            //FrmAssist.UpdateColumns(ref mDtDicOfAccount, dt,10);


            dgAccount.AutoGenerateColumns = false;
            dgAccount.DataSource = dt;
            dgAccount.Columns[0].Visible = false;


        }
    }
}
