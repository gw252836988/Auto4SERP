using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auto4SErp.Repair
{
    public partial class frmDlgAccIn : ifrmBase
    {

        public double Amount
        {
            get;
            set;

        }

        public double InPrice
        {
            get;
            set;

        }
        public frmDlgAccIn()
        {
            InitializeComponent();
        }

        private void frmDlgAccIn_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
            dbiAmount.Value = Amount;
            dbiInPrice.Value = InPrice;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {


            if (m_del != null)
                m_del(dbiAmount.Value + "," + dbiInPrice.Value);
            this.Close();
        }


    }
}
