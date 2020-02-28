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
    public partial class frmDlgPriceInOfTake : ifrmBase
    {
        public frmDlgPriceInOfTake()
        {
            InitializeComponent();
        }

        private void frmDlgPriceInOfTake_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (m_del != null)
                m_del(dbiSalePrice.Value);
            this.Close();
        }
    }
}
