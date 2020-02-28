﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using Bll.Repair;
namespace Auto4SErp.Report
{
    public partial class frmRPVOfRepair : ifrmBase
    {
        private IRepair mIRepair;
        public frmRPVOfRepair()
        {
            InitializeComponent();
            mIRepair = BllFactory.GetRepariBll();
        }

        private void frmRPVOfRepair_Load(object sender, EventArgs e)
        {
            nudYear.Value = int.Parse(DateTime.Now.Year.ToString());
            SetTButtonPng(toolStrip1);
            DoQuery();
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        protected override void DoQuery()
        {


            //tChart1.Series[0].XValues.Clear();

            //tChart1.Series[0].YValues.Clear();

            double[] jc = new double[12];
            List<string> lst = new List<string>();
            string strresult;
            for (int i = 1; i <= 12; i++)
            {
                strresult = mIRepair.GetPVOfRepair(nudYear.Value, i, chbRepair.Checked, chbClaim.Checked, false);
                jc[i - 1] = double.Parse(strresult);
                lst.Add(i + "月");
            }

            //tChart1.Series[0].Add(jc);
            //tChart1.Series[0].Labels.AddRange(lst);
            chart1.Series[0].Points.DataBindXY(lst, jc);

        }

    }
}
