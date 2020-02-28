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
using Comm;
namespace Auto4SErp.Report
{
    public partial class frmRReceptReport : ifrmBase
    {
        private IRepair mIRepair;
        public frmRReceptReport()
        {
            mIRepair = Bll.BllFactory.GetRepariBll();
            InitializeComponent();
        }

        private void frmRReceptReport_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "/" + dtNow.Month + "/01 00:00");
            SetTButtonPng(toolStrip1);
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        protected override void DoQuery()
        {
            string strBegin = "";
            string strEnd = "";

            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";


            DataTable dt = mIRepair.GetReceptReport(strBegin, strEnd);
            dgRepair.AutoGenerateColumns = false;
            dgRepair.DataSource = dt;
            GenerateElseData(dt);
        }

        private void GenerateElseData(DataTable dt)
        {
            string strBegin = "";
            string strEnd = "";

            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";
            DataTable dtNew = new DataTable();
            dtNew.Columns.Add("ReceptMan", typeof(string));
            dtNew.Columns.Add("keepprice", typeof(string));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dtNew.NewRow();
                dr["ReceptMan"] = dt.Rows[i]["ReceptMan"];
                dr["keepprice"] = mIRepair.GetKeepAccValue(strBegin, strEnd, dt.Rows[i]["ReceptMan"].ToString());
                dtNew.Rows.Add(dr);

            }

            dgElse.DataSource = dtNew;
        }
    }
}
