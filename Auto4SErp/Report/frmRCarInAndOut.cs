﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using Bll.Sale;
namespace Auto4SErp.Report
{
    public partial class frmRCarInAndOut : ifrmBase
    {

        private ICarStock mICarStock;
        public frmRCarInAndOut()
        {
            mICarStock = BllFactory.GetCarStockBll();
            InitializeComponent();
        }

        private void frmRCarInAndOut_Load(object sender, EventArgs e)
        {
            nudYear.Value = int.Parse(DateTime.Now.Year.ToString());
            SetTButtonPng(toolStrip1);
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DataTable dt = mICarStock.GetCarsOutAndInReport(nudYear.Value.ToString());
            dgInAndOut.DataSource = dt;

        }
    }
}
