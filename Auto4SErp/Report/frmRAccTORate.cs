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
    public partial class frmRAccTORate : ifrmBase
    {
        private IAccessory mIAccessory;
        public frmRAccTORate()
        {
            InitializeComponent();
            mIAccessory = BllFactory.GetAccessoryBll();
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            dgResult.DataSource = CreateDataTable();
        }


        private DataTable CreateDataTable()
        {
            DataTable dtResult;
            dtResult = new DataTable();

            dtResult.Columns.Add("月份");
            dtResult.Columns.Add("出库金额");
            dtResult.Columns.Add("期初库存");
            dtResult.Columns.Add("期末库存");
            dtResult.Columns.Add("本月周转率");
            int currentmonth = DateTime.Now.Month;
            int year = nudYear.Value;
            // decimal  g_accout = 0;
            //decimal g_accstock = 0;
            decimal accout;
            decimal accbeginstock;
            decimal accendtock;
            decimal torate = 0;
            int PreYear;
            int PreMonth;
            //不包含当前月


            int currentyear = DateTime.Now.Year;
            if (year > currentyear)
                currentmonth = 1;
            else if (year < currentyear)
                currentmonth = 13;

            for (int i = 1; i < currentmonth; i++)
            {
                DataRow dr = dtResult.NewRow();
                if (i == 1)
                {
                    PreYear = year - 1;
                    PreMonth = 12;
                }
                else
                {
                    PreYear = year;
                    PreMonth = i - 1;
                }

                dr[0] = i + "月";
                accout = mIAccessory.GetAmountOfAccOutInMonth(year, i);

                accbeginstock = mIAccessory.GetAmountOfAccStockInMonth(PreYear, PreMonth);
                accendtock = mIAccessory.GetAmountOfAccStockInMonth(year, i);
                dr[1] = accout;
                dr[2] = accbeginstock;
                dr[3] = accendtock;
                if (accout != 0)
                    torate = (accbeginstock + accendtock) / 2 / accout;
                torate = Math.Round(torate, 2);
                dr[4] = torate;
                // g_accout += accout;
                // g_accstock += accstock;
                dtResult.Rows.Add(dr);
            }
            //decimal torate = (g_accstock / (currentmonth - 1));
            //torate = g_accout / torate;
            //torate = Math.Round(torate, 2);
            //txtTORate.Text = torate.ToString();
            return dtResult;
        }

        private void frmRAccTORate_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
            nudYear.Value = DateTime.Now.Year;
        }
    }
}
