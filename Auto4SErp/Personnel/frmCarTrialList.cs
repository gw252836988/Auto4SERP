using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll.Personnel;
using Bll;
using Model;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Bll.Sale;

namespace Auto4SErp.Personnel
{
    public partial class frmCarTrialList : ifrmBase
    {
        private int Year = 2019;
        private int Month = 11;
        private IAward mIAward = BllFactory.GetAwardBll();
        public frmCarTrialList()
        {
            InitializeComponent();
        }

        private void frmCarTrialList_Load(object sender, EventArgs e)
        {
            cmbYear.Text = DateTime.Now.Year.ToString();
            cmbMonth.Text = DateTime.Now.Month.ToString();
            BindData();
        }
        private void BindData()
        {
         
            Year = int.Parse(cmbYear.Text);
            Month = int.Parse(cmbMonth.Text);

            DataTable dt = mIAward.GetCarTrialRecord(Year, Month,txtStaffID.Text,txtOrgan.Text);      
            gridCarTrial.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCarTrialInput frm = new frmCarTrialInput();
            frm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCarTrial_FormClosed);
            frm.ShowDialog();
        }

        private void frmCarTrial_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
