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
namespace Auto4SErp
{
    public partial class frmRefund : ifrmBase
    {

        private int iD;
        private IFinance mIFinance;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public frmRefund()
        {
            InitializeComponent();
            mIFinance = BllFactory.GetFinanceBll();
        }

        private void tbtnOK_Click(object sender, EventArgs e)
        {

            mIFinance.AfterRefund(iD);
            this.Close();

        }

        private void frmRefund_Load(object sender, EventArgs e)
        {
            cmbRefundTo.SelectedIndex = 0;
            SetTButtonPng(toolStrip1);
        }
    }
}
