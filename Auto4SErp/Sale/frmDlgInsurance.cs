using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll.Sale;
using Bll;
namespace Auto4SErp.Sale
{
    public partial class frmDlgInsurance : ifrmBase
    {
        private ICarStock mICarStock;
        public frmDlgInsurance()
        {
            InitializeComponent();
            mICarStock = Bll.BllFactory.GetCarStockBll();
        }

        public double InsuranceJe
        {
            get;
            set;

        }

        public double BTPrice
        {
            get;
            set;

        }


        public string VinOld
        {
            get;
            set;

        }
        private void frmDlgInsurance_Load(object sender, EventArgs e)
        {
            dbiAmountRe.Value = InsuranceJe;
            dbiBTPrice.Value = BTPrice;
            SetTButtonPng(toolStrip1);
            if (Comm.LoginInfoShare.getInstance().UserId != "admin")
                btnChange.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {


            if (m_del != null)
            {
                InsuranceJe = dbiAmountRe.Value;
                BTPrice = dbiBTPrice.Value;

                //anonymousObj = new { Insurance = dbiAmountRe.Value, BTPrice = dbiBTPrice.Value };
                m_del(null);


            }
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            mICarStock.ChangeVinOfSale(VinOld, txtVin.Text);
        }
    }
}
