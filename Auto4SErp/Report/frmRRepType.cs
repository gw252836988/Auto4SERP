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
    public partial class frmRRepType : ifrmBase
    {

        private IRepair mIRepair;
        public frmRRepType()
        {
            mIRepair = BllFactory.GetRepariBll();
            InitializeComponent();
        }

        private void frmRRepType_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            SetTButtonPng(toolStrip1);
            DoQuery();
        }



        protected override void DoQuery()
        {
            string strBegin = "";
            string strEnd = "";
            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";


            DataTable dt;
            dt = mIRepair.GetRepType(strBegin, strEnd);
            dgRepair.DataSource = dt;

        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
           
        }
    }
}
