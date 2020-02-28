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
namespace Auto4SErp.Sale
{
    public partial class frmDlgLimitPrice : ifrmBase
    {

        private ICarDoc mICarDoc;
        public string AutoNumber
        {

            get;
            set;
        }

        public frmDlgLimitPrice()
        {
            InitializeComponent();
            mICarDoc = BllFactory.GetCarDocBll();
        }

        private void frmDlgLimitPrice_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
            nudYear.Value = int.Parse(DateTime.Now.Year.ToString());
            DoQuery();
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();

        }


        protected override void DoQuery()
        {

            dgResult.DataSource = mICarDoc.GetSalePricesOfYear(nudYear.Value, AutoNumber);
        }
    }
}
